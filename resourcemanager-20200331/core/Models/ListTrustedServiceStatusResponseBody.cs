// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListTrustedServiceStatusResponseBody : TeaModel {
        [NameInMap("EnabledServicePrincipals")]
        [Validation(Required=false)]
        public ListTrustedServiceStatusResponseBodyEnabledServicePrincipals EnabledServicePrincipals { get; set; }
        public class ListTrustedServiceStatusResponseBodyEnabledServicePrincipals : TeaModel {
            [NameInMap("EnabledServicePrincipal")]
            [Validation(Required=false)]
            public List<ListTrustedServiceStatusResponseBodyEnabledServicePrincipalsEnabledServicePrincipal> EnabledServicePrincipal { get; set; }
            public class ListTrustedServiceStatusResponseBodyEnabledServicePrincipalsEnabledServicePrincipal : TeaModel {
                [NameInMap("EnableTime")]
                [Validation(Required=false)]
                public string EnableTime { get; set; }

                [NameInMap("ServicePrincipal")]
                [Validation(Required=false)]
                public string ServicePrincipal { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD76D376-2517-4924-92C5-DBC52262F93A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
