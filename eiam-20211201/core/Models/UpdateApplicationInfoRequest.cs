// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateApplicationInfoRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ram Account SSO</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The application owner.</para>
        /// </summary>
        [NameInMap("ApplicationOwner")]
        [Validation(Required=false)]
        public UpdateApplicationInfoRequestApplicationOwner ApplicationOwner { get; set; }
        public class UpdateApplicationInfoRequestApplicationOwner : TeaModel {
            /// <summary>
            /// <para>The list of group IDs.</para>
            /// </summary>
            [NameInMap("GroupIds")]
            [Validation(Required=false)]
            public List<string> GroupIds { get; set; }

            /// <summary>
            /// <para>The list of user IDs.</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// <para>The application visibility settings.</para>
        /// </summary>
        [NameInMap("ApplicationVisibility")]
        [Validation(Required=false)]
        public List<string> ApplicationVisibility { get; set; }

        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of application extension fields.</para>
        /// </summary>
        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public List<UpdateApplicationInfoRequestCustomFields> CustomFields { get; set; }
        public class UpdateApplicationInfoRequestCustomFields : TeaModel {
            /// <summary>
            /// <para>The name of the application extension field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_type</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The value of the application extension field. If FieldName is set to agentType, valid values are bailian, pai, dify, and volcano. If FieldName is set to agentExternalId, enter the relevant value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <para>The operation type for the application extension field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

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
        /// <para>The URL of the application logo.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.aliyuncs.com/logo.png">https://example.aliyuncs.com/logo.png</a></para>
        /// </summary>
        [NameInMap("LogoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

    }

}
