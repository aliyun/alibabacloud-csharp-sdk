// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveSnapshotDetectPornConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

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
        /// <para>The interval at which snapshots are captured from the live stream. Valid values: <b>5 to 3600</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// <para>After the review is complete, you can search for specific violations in the OSS console based on the callback information. You must create the OSS bucket in advance. For more information, see <a href="https://help.aliyun.com/document_detail/199449.html">Configure content moderation</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>livebucket</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The endpoint of the Object Storage Service (OSS) bucket.</para>
        /// <para>After the review is complete, you can search for specific violations in the OSS console based on the callback information. You must configure the OSS endpoint in advance. For more information, see <a href="https://help.aliyun.com/document_detail/199449.html">Configure content moderation</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-oss-****.aliyuncs.com</para>
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// <para>The name of the snapshot that stores violations such as pornographic content and politically sensitive content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>record/{AppName}/{StreamName}/{Sequence}.jpg</para>
        /// </summary>
        [NameInMap("OssObject")]
        [Validation(Required=false)]
        public string OssObject { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Scene list detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public List<string> Scene { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
