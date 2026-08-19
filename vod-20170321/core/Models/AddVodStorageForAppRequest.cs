// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddVodStorageForAppRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. The application ID is the value of the <c>AppId</c> parameter returned by the <a href="~~CreateAppInfo~~">CreateAppInfo</a> or <a href="~~ListAppInfo~~">ListAppInfo</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The OSS bucket address. This parameter is required when StorageType is set to user_oss_bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-bucket.oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vod_oss_bucket</description></item>
        /// <item><description>user_oss_bucket</description></item>
        /// </list>
        /// <para>Default value: <b>vod_oss_bucket</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vod_oss_bucket</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
