// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateDataServiceAppRequest : TeaModel {
        /// <summary>
        /// <para>The command to create a data service application.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateDataServiceAppRequestCreateCommand CreateCommand { get; set; }
        public class CreateDataServiceAppRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The application group ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200000000</para>
            /// </summary>
            [NameInMap("AppGroupId")]
            [Validation(Required=false)]
            public int? AppGroupId { get; set; }

            /// <summary>
            /// <para>The application key, which must be globally unique and is used when calling APIs.
            /// The key must be 8 to 128 characters in length and can contain letters, digits, underscores (_), and hyphens (-).
            /// This parameter can be customized only when using Alibaba Cloud API Gateway or the built-in gateway. This parameter is ignored when using a dedicated cloud gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200000001</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认应用</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The app secret.
            /// If this parameter is not specified, the system automatically generates a new AppSecret value.
            /// The secret must be 8 to 127 characters in length and can contain letters, digits, underscores (_), and hyphens (-).
            /// This parameter can be customized only when using Alibaba Cloud API Gateway or the built-in gateway. This parameter is ignored when using a dedicated cloud gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc123456789</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>The list of owner IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("OwnerIds")]
            [Validation(Required=false)]
            public List<string> OwnerIds { get; set; }

            /// <summary>
            /// <para>Common scenarios.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>数据分析</para>
            /// </summary>
            [NameInMap("Scenarios")]
            [Validation(Required=false)]
            public string Scenarios { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
