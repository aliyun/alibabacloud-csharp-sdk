// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hls</para>
        /// </summary>
        [NameInMap("FileFormat")]
        [Validation(Required=false)]
        public string FileFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("Flv")]
        [Validation(Required=false)]
        public string Flv { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("HlsM3u8")]
        [Validation(Required=false)]
        public string HlsM3u8 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{UnixTimestamp}_{Sequence}</para>
        /// </summary>
        [NameInMap("HlsTs")]
        [Validation(Required=false)]
        public string HlsTs { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>323*****998-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}_ondemand.jpg</para>
        /// </summary>
        [NameInMap("JpgOnDemand")]
        [Validation(Required=false)]
        public string JpgOnDemand { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}.jpg</para>
        /// </summary>
        [NameInMap("JpgOverwrite")]
        [Validation(Required=false)]
        public string JpgOverwrite { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}.jpg</para>
        /// </summary>
        [NameInMap("JpgSequence")]
        [Validation(Required=false)]
        public string JpgSequence { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("Mp4")]
        [Validation(Required=false)]
        public string Mp4 { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bucketname</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss-cn-qingdao.aliyuncs.com</para>
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss-prefix</para>
        /// </summary>
        [NameInMap("OssFilePrefix")]
        [Validation(Required=false)]
        public string OssFilePrefix { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;Fps&quot;:25,&quot;Gop&quot;:50,&quot;Height&quot;:720,&quot;VideoCodec&quot;:&quot;h264&quot;,&quot;Width&quot;:1280,&quot;Name&quot;:&quot;sd&quot;,&quot;VideoBitrate&quot;:800}]</para>
        /// </summary>
        [NameInMap("TransConfigsJSON")]
        [Validation(Required=false)]
        public string TransConfigsJSON { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string Trigger { get; set; }

    }

}
