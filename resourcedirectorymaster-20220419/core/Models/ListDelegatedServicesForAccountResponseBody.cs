// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListDelegatedServicesForAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the trusted services.</para>
        /// <remarks>
        /// <para>If the value of this parameter is empty, the member is not specified as a delegated administrator account.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DelegatedServices")]
        [Validation(Required=false)]
        public ListDelegatedServicesForAccountResponseBodyDelegatedServices DelegatedServices { get; set; }
        public class ListDelegatedServicesForAccountResponseBodyDelegatedServices : TeaModel {
            [NameInMap("DelegatedService")]
            [Validation(Required=false)]
            public List<ListDelegatedServicesForAccountResponseBodyDelegatedServicesDelegatedService> DelegatedService { get; set; }
            public class ListDelegatedServicesForAccountResponseBodyDelegatedServicesDelegatedService : TeaModel {
                /// <summary>
                /// <para>The time when the member was specified as a delegated administrator account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1616652684164</para>
                /// </summary>
                [NameInMap("DelegationEnabledTime")]
                [Validation(Required=false)]
                public string DelegationEnabledTime { get; set; }

                /// <summary>
                /// <para>The identifier of the trusted service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloudfw.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ServicePrincipal")]
                [Validation(Required=false)]
                public string ServicePrincipal { get; set; }

                /// <summary>
                /// <para>The status of the trusted service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ENABLED: enabled</description></item>
                /// <item><description>DISABLED: disabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9C03B94-9396-4794-A74B-13DC437556A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
