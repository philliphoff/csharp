// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// specification of a horizontal pod autoscaler.
    /// </summary>
    public partial class V1HorizontalPodAutoscalerSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1HorizontalPodAutoscalerSpec
        /// class.
        /// </summary>
        public V1HorizontalPodAutoscalerSpec()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1HorizontalPodAutoscalerSpec
        /// class.
        /// </summary>
        /// <param name="maxReplicas">upper limit for the number of pods that
        /// can be set by the autoscaler; cannot be smaller than
        /// MinReplicas.</param>
        /// <param name="scaleTargetRef">reference to scaled resource;
        /// horizontal pod autoscaler will learn the current resource
        /// consumption and will set the desired number of pods by using its
        /// Scale subresource.</param>
        /// <param name="minReplicas">lower limit for the number of pods that
        /// can be set by the autoscaler, default 1.</param>
        /// <param name="targetCPUUtilizationPercentage">target average CPU
        /// utilization (represented as a percentage of requested CPU) over all
        /// the pods; if not specified the default autoscaling policy will be
        /// used.</param>
        public V1HorizontalPodAutoscalerSpec(int maxReplicas, V1CrossVersionObjectReference scaleTargetRef, int? minReplicas = default(int?), int? targetCPUUtilizationPercentage = default(int?))
        {
            MaxReplicas = maxReplicas;
            MinReplicas = minReplicas;
            ScaleTargetRef = scaleTargetRef;
            TargetCPUUtilizationPercentage = targetCPUUtilizationPercentage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets upper limit for the number of pods that can be set by
        /// the autoscaler; cannot be smaller than MinReplicas.
        /// </summary>
        [JsonProperty(PropertyName = "maxReplicas")]
        public int MaxReplicas { get; set; }

        /// <summary>
        /// Gets or sets lower limit for the number of pods that can be set by
        /// the autoscaler, default 1.
        /// </summary>
        [JsonProperty(PropertyName = "minReplicas")]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// Gets or sets reference to scaled resource; horizontal pod
        /// autoscaler will learn the current resource consumption and will set
        /// the desired number of pods by using its Scale subresource.
        /// </summary>
        [JsonProperty(PropertyName = "scaleTargetRef")]
        public V1CrossVersionObjectReference ScaleTargetRef { get; set; }

        /// <summary>
        /// Gets or sets target average CPU utilization (represented as a
        /// percentage of requested CPU) over all the pods; if not specified
        /// the default autoscaling policy will be used.
        /// </summary>
        [JsonProperty(PropertyName = "targetCPUUtilizationPercentage")]
        public int? TargetCPUUtilizationPercentage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ScaleTargetRef == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ScaleTargetRef");
            }
            if (ScaleTargetRef != null)
            {
                ScaleTargetRef.Validate();
            }
        }
    }
}
