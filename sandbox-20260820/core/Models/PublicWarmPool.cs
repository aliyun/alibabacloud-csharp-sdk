// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicWarmPool : TeaModel {
        /// <summary>
        /// <para>The most recent observation time of the capacity status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-12-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("capacityObservedTime")]
        [Validation(Required=false)]
        public string CapacityObservedTime { get; set; }

        /// <summary>
        /// <para>The capacity policy of the warm pool, which includes the base target capacity and optional scheduled rules.</para>
        /// </summary>
        [NameInMap("capacityPolicy")]
        [Validation(Required=false)]
        public WarmPoolCapacityPolicy CapacityPolicy { get; set; }

        /// <summary>
        /// <para>The masked text of the current background error. This value is null if no error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SourceNotFound: source template does not exist</para>
        /// </summary>
        [NameInMap("currentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        /// <summary>
        /// <para>Indicates whether the warm pool is being deleted.</para>
        /// </summary>
        [NameInMap("deleting")]
        [Validation(Required=false)]
        public bool? Deleting { get; set; }

        /// <summary>
        /// <para>The number of sandboxes that are currently being prepared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("preparing")]
        [Validation(Required=false)]
        public long? Preparing { get; set; }

        /// <summary>
        /// <para>The number of sandboxes that are currently ready.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ready")]
        [Validation(Required=false)]
        public long? Ready { get; set; }

        /// <summary>
        /// <para>The number of sandboxes that are currently being released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("releasing")]
        [Validation(Required=false)]
        public long? Releasing { get; set; }

        /// <summary>
        /// <para>Indicates whether the source of the associated template is unavailable.</para>
        /// </summary>
        [NameInMap("sourceUnavailable")]
        [Validation(Required=false)]
        public bool? SourceUnavailable { get; set; }

        /// <summary>
        /// <para>The current target capacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("targetCapacity")]
        [Validation(Required=false)]
        public long? TargetCapacity { get; set; }

        /// <summary>
        /// <para>The team ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team-example1234567890</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The template ID, which specifies the template associated with the warm pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpl-example1234567890</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
