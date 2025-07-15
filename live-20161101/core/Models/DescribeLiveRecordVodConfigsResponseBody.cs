// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordVodConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations.</para>
        /// </summary>
        [NameInMap("LiveRecordVodConfigs")]
        [Validation(Required=false)]
        public DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigs LiveRecordVodConfigs { get; set; }
        public class DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigs : TeaModel {
            [NameInMap("LiveRecordVodConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigsLiveRecordVodConfig> LiveRecordVodConfig { get; set; }
            public class DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigsLiveRecordVodConfig : TeaModel {
                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>Indicates whether automatic merging is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ON</b></description></item>
                /// <item><description><b>OFF</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("AutoCompose")]
                [Validation(Required=false)]
                public string AutoCompose { get; set; }

                /// <summary>
                /// <para>The ID of the transcoding template group that was used to automatically merge the VOD files created from the live streams.</para>
                /// <remarks>
                /// <para> This parameter is returned if the value of the AutoCompose parameter is ON.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>dadfcaadde****</para>
                /// </summary>
                [NameInMap("ComposeVodTranscodeGroupId")]
                [Validation(Required=false)]
                public string ComposeVodTranscodeGroupId { get; set; }

                /// <summary>
                /// <para>The time when the live stream was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-01T17:37:00Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The recording cycle. Unit: seconds. Default value: <b>3600</b>. Valid values: <b>300 to 21600</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>360</para>
                /// </summary>
                [NameInMap("CycleDuration")]
                [Validation(Required=false)]
                public int? CycleDuration { get; set; }

                /// <summary>
                /// <para>The main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>Indicates whether on-demand recording is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b> (default): On-demand recording is disabled.</description></item>
                /// <item><description><b>1</b>: On-demand recording is enabled by using the HTTP callback method.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OnDemand")]
                [Validation(Required=false)]
                public int? OnDemand { get; set; }

                /// <summary>
                /// <para>The storage location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>****-tjptr2vatm.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveStream****</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The ID of the transcoding template group in ApsaraVideo VOD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e2d796d3bb5fd8049d32bff62f94****</para>
                /// </summary>
                [NameInMap("VodTranscodeGroupId")]
                [Validation(Required=false)]
                public string VodTranscodeGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5056369B-D337-499E-B8B7-B761BD37B08A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
