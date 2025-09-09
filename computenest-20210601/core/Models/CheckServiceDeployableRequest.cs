// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CheckServiceDeployableRequest : TeaModel {
        /// <summary>
        /// <para>Total amount of postpaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.29</para>
        /// </summary>
        [NameInMap("PostPaidAmount")]
        [Validation(Required=false)]
        public string PostPaidAmount { get; set; }

        /// <summary>
        /// <para>Total amount of prepayment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("PrePaidAmount")]
        [Validation(Required=false)]
        public string PrePaidAmount { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-0e6fca6a51a544xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The trial type of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Trial</b>: Trials are supported.</description></item>
        /// <item><description><b>NotTrial</b>: Trials are not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NotTrial</para>
        /// </summary>
        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

    }

}
