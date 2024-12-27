// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetDRMLicenseRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AESzB8SQgpACioSEJ3yqiFwruAOUgIvlCx*****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://1111111111.mns.cn-hangzhou.aliyuncs.com">http://1111111111.mns.cn-hangzhou.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>topic1</para>
        /// </summary>
        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>widevine</para>
        /// </summary>
        [NameInMap("ProtectionSystem")]
        [Validation(Required=false)]
        public string ProtectionSystem { get; set; }

    }

}
