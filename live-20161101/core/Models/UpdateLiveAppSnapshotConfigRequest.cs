// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveAppSnapshotConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The callback URL that is used to receive notifications about snapshot capture.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://learn.aliyundoc.com">https://learn.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveBucket****</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The endpoint of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-oss-****.aliyuncs.com</para>
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// <para>The naming format of snapshots that are stored in the overwrite mode, which means that a new snapshot overwrites the previous snapshot.</para>
        /// <list type="bullet">
        /// <item><description>The name must be less than 256 bytes in length.</description></item>
        /// <item><description>Only JPG images are supported.</description></item>
        /// <item><description>The name can contain variables such as {AppName} and {StreamName}.</description></item>
        /// <item><description>A value of hyphen (-) indicates that this parameter is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{liveApp****}/{liveStream****}.jpg</para>
        /// </summary>
        [NameInMap("OverwriteOssObject")]
        [Validation(Required=false)]
        public string OverwriteOssObject { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The naming format of snapshots that are stored in sequence, which means that a new snapshot does not overwrite the previous snapshot. You can call the <a href="https://help.aliyun.com/document_detail/2847902.html">DescribeLiveStreamSnapshotInfo</a> operation to query the snapshots that were captured within a specific time period.</para>
        /// <list type="bullet">
        /// <item><description>The name must be less than 256 bytes in length.</description></item>
        /// <item><description>Only JPG images are supported.</description></item>
        /// <item><description>The name can contain variables such as {AppName}, {StreamName}, {UnixTimestamp}, and {Sequence}. The name must contain at least one of the {UnixTimestamp} and {Sequence} variables.</description></item>
        /// <item><description>A value of hyphen (-) indicates that this parameter is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot/{liveApp****}/{liveStream****}/{UnixTimestamp****}.jpg</para>
        /// </summary>
        [NameInMap("SequenceOssObject")]
        [Validation(Required=false)]
        public string SequenceOssObject { get; set; }

        /// <summary>
        /// <para>The interval at which snapshots are captured. Valid values: <b>5 to 3600</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TimeInterval")]
        [Validation(Required=false)]
        public int? TimeInterval { get; set; }

    }

}
