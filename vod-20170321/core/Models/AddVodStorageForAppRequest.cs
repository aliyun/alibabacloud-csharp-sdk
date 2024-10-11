// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddVodStorageForAppRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of applications. You can obtain the application ID from the <c>AppId</c> parameter in the response to the <a href="~~CreateAppInfo~~">CreateAppInfo</a> or <a href="~~ListAppInfo~~">ListAppInfo</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The address of an Object Storage Service (OSS) bucket. This parameter does not take effect. You can call this operation to add only VOD buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>out-****.oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The storage class. Default value: <b>vod_oss_bucket</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vod_oss_bucket</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
