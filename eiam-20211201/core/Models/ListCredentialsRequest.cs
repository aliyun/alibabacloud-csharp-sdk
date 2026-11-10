// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCredentialsRequest : TeaModel {
        /// <summary>
        /// <para>The external unique identifiers of the credentials.</para>
        /// </summary>
        [NameInMap("CredentialExternalIds")]
        [Validation(Required=false)]
        public List<string> CredentialExternalIds { get; set; }

        /// <summary>
        /// <para>The credential IDs.</para>
        /// </summary>
        [NameInMap("CredentialIds")]
        [Validation(Required=false)]
        public List<string> CredentialIds { get; set; }

        /// <summary>
        /// <para>The credential sharing scopes.</para>
        /// </summary>
        [NameInMap("CredentialSharingScopes")]
        [Validation(Required=false)]
        public List<string> CredentialSharingScopes { get; set; }

        /// <summary>
        /// <para>The credential types.</para>
        /// </summary>
        [NameInMap("CredentialTypes")]
        [Validation(Required=false)]
        public List<string> CredentialTypes { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListCredentialsRequestFilter> Filter { get; set; }
        public class ListCredentialsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the filter field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CredentialIdentifier: The credential identifier.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CredentialIdentifier</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The values for the filter field.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of records per page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The credential statuses.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
