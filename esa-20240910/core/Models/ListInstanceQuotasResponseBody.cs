// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListInstanceQuotasResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListInstanceQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListInstanceQuotasResponseBodyQuotas : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>customHttpCert</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public string QuotaValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bool</para>
            /// </summary>
            [NameInMap("QuotaValueType")]
            [Validation(Required=false)]
            public string QuotaValueType { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247B78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
