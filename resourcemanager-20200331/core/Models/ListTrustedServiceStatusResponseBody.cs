// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListTrustedServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The trusted services that are enabled.</para>
        /// </summary>
        [NameInMap("EnabledServicePrincipals")]
        [Validation(Required=false)]
        public ListTrustedServiceStatusResponseBodyEnabledServicePrincipals EnabledServicePrincipals { get; set; }
        public class ListTrustedServiceStatusResponseBodyEnabledServicePrincipals : TeaModel {
            [NameInMap("EnabledServicePrincipal")]
            [Validation(Required=false)]
            public List<ListTrustedServiceStatusResponseBodyEnabledServicePrincipalsEnabledServicePrincipal> EnabledServicePrincipal { get; set; }
            public class ListTrustedServiceStatusResponseBodyEnabledServicePrincipalsEnabledServicePrincipal : TeaModel {
                /// <summary>
                /// <para>The time when the trusted service was enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-18T15:32:10.473Z</para>
                /// </summary>
                [NameInMap("EnableTime")]
                [Validation(Required=false)]
                public string EnableTime { get; set; }

                /// <summary>
                /// <para>The identification of the trusted service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>config.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ServicePrincipal")]
                [Validation(Required=false)]
                public string ServicePrincipal { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD76D376-2517-4924-92C5-DBC52262F93A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
