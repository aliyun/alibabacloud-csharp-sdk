// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserProvisioningConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBC2ED1D-FAC5-3DF8-B63C-992B85B08DD9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The global configurations of the RAM user provisioning.</para>
        /// </summary>
        [NameInMap("UserProvisioningConfiguration")]
        [Validation(Required=false)]
        public UpdateUserProvisioningConfigurationResponseBodyUserProvisioningConfiguration UserProvisioningConfiguration { get; set; }
        public class UpdateUserProvisioningConfigurationResponseBodyUserProvisioningConfiguration : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28T03:55:42Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The default URL for a CloudSSO user who logs on to the Alibaba Cloud Management Console.</para>
            /// <para>Default value: <a href="https://homenew.console.aliyun.com">https://homenew.console.aliyun.com</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://homenew.console.aliyun.com">https://homenew.console.aliyun.com</a></para>
            /// </summary>
            [NameInMap("DefaultLandingPage")]
            [Validation(Required=false)]
            public string DefaultLandingPage { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-003qew84****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The duration of the logon session.</para>
            /// <para>Unit: hours.</para>
            /// <para>Valid values: 1 to 24.</para>
            /// <para>Default value: 6.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public int? SessionDuration { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28T03:55:42Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
