// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSecretsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of access credentials.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried access credentials.</para>
        /// </summary>
        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public ListSecretsResponseBodySecrets Secrets { get; set; }
        public class ListSecretsResponseBodySecrets : TeaModel {
            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public List<ListSecretsResponseBodySecretsSecrets> Secrets { get; set; }
            public class ListSecretsResponseBodySecretsSecrets : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1033***</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp14****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The description of the access credential.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the access credential for the created Data API account. Format: <c>acs:gpdb:{{region}}:{{accountId}}:secret/{{secretName}}-{{32 digits random string}</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:gpdb:cn-beijing:1033**:secret/testsecret-eG2AQGRIwQ0zFp4VA7mYL3uiCXTfDQbQ</para>
                /// </summary>
                [NameInMap("SecretArn")]
                [Validation(Required=false)]
                public string SecretArn { get; set; }

                /// <summary>
                /// <para>The name of the access credential.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testsecret</para>
                /// </summary>
                [NameInMap("SecretName")]
                [Validation(Required=false)]
                public string SecretName { get; set; }

                /// <summary>
                /// <para>The name of the database account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testacc</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        /// <summary>
        /// <para>The status of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b></description></item>
        /// <item><description><b>fail</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
