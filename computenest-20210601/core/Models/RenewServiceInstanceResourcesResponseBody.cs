// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class RenewServiceInstanceResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of failed renewals.</para>
        /// </summary>
        [NameInMap("FailureDetails")]
        [Validation(Required=false)]
        public List<RenewServiceInstanceResourcesResponseBodyFailureDetails> FailureDetails { get; set; }
        public class RenewServiceInstanceResourcesResponseBodyFailureDetails : TeaModel {
            /// <summary>
            /// <para>Error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidPeriod</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Error message</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Resource ARN (Aliyun Resource Name).</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ecs:cn-hongkong:1488317743351199:instance/i-j6c6f3lbky38o8rpeqw2</para>
            /// </summary>
            [NameInMap("ResourceArn")]
            [Validation(Required=false)]
            public string ResourceArn { get; set; }

        }

        /// <summary>
        /// <para>Renewal result.</para>
        /// </summary>
        [NameInMap("RenewalResult")]
        [Validation(Required=false)]
        public RenewServiceInstanceResourcesResponseBodyRenewalResult RenewalResult { get; set; }
        public class RenewServiceInstanceResourcesResponseBodyRenewalResult : TeaModel {
            /// <summary>
            /// <para>Number of failed renewals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public int? Failed { get; set; }

            /// <summary>
            /// <para>Number of successfully renewed resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public int? Succeeded { get; set; }

            /// <summary>
            /// <para>Number of renewed resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13FE89A5-C036-56BF-A0FF-A31C59819FD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
