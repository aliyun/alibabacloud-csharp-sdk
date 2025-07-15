// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveAudioAuditConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. The value of this parameter must be the same as the application name in the ingest URL. Otherwise, the configuration does not take effect. The application name is case-sensitive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The business type. You can specify a model. The default value is the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.edu</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

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
        /// <para>The name of the OSS bucket in which the recording is stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveBucket****</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The endpoint of OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-oss-****.aliyuncs.com</para>
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// <para>The name of the recording stored in OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveObject****</para>
        /// </summary>
        [NameInMap("OssObject")]
        [Validation(Required=false)]
        public string OssObject { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the live stream. The value of this parameter must be the same as the stream name in the ingest URL. Otherwise, the configuration does not take effect. The stream name is case-sensitive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
