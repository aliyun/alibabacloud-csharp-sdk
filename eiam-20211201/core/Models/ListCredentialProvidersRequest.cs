// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCredentialProvidersRequest : TeaModel {
        /// <summary>
        /// <para>List of credential provider IDs.</para>
        /// </summary>
        [NameInMap("CredentialProviderIds")]
        [Validation(Required=false)]
        public List<string> CredentialProviderIds { get; set; }

        /// <summary>
        /// <para>List of credential provider types.</para>
        /// </summary>
        [NameInMap("CredentialProviderTypes")]
        [Validation(Required=false)]
        public List<string> CredentialProviderTypes { get; set; }

        /// <summary>
        /// <para>List of filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListCredentialProvidersRequestFilter> Filter { get; set; }
        public class ListCredentialProvidersRequestFilter : TeaModel {
            /// <summary>
            /// <para>Filter condition name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CredentialProviderName: Credential provider name.</para>
            /// </description></item>
            /// <item><description><para>CredentialProviderIdentifier: Credential provider identifier.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CredentialProviderName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>List of filter condition values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Page size for paged queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Query token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>List of credential provider statuses.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
