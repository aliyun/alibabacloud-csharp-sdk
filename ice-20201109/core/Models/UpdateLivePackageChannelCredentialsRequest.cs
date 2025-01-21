// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLivePackageChannelCredentialsRequest : TeaModel {
        /// <summary>
        /// <para>频道名称，字符必须为大小写英文字母或-、<em>。
        /// 1 ~ 200个字符。
        /// 格式：[A-Za-z0-9</em>-]+</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>频道组名称</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>刷新密钥选项, 1: 刷新endpoint1，2:刷新endpoint2，3: 刷新endpoint1&amp;2</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RotateCredentials")]
        [Validation(Required=false)]
        public int? RotateCredentials { get; set; }

    }

}
