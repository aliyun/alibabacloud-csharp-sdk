// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLivePackageConfigRequest : TeaModel {
        /// <summary>
        /// <para>The AppName must match the AppName in the ingest URL for the template to take effect. The AppName can be up to 255 characters in length and can contain digits, uppercase letters, lowercase letters, hyphens (-), and underscores (_). A hyphen or an underscore cannot be the first character. You can also set this parameter to a single asterisk (\*) to match all AppNames.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppName</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The live streaming domain name. This is the primary playback domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore transcoded streams. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): Ignore transcoded streams.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not ignore transcoded streams.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IgnoreTranscode")]
        [Validation(Required=false)]
        public bool? IgnoreTranscode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The length of the part segment, in milliseconds.</para>
        /// <list type="bullet">
        /// <item><description><para>If SegmentDuration is 1 s, the valid values are 100 to 500. The default value is 350.</para>
        /// </description></item>
        /// <item><description><para>If SegmentDuration is 2 s, the valid values are 100 to 1000. The default value is 700.</para>
        /// </description></item>
        /// <item><description><para>This parameter is valid only when you set Protocol to LLHLS_\*.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>350</para>
        /// </summary>
        [NameInMap("PartDuration")]
        [Validation(Required=false)]
        public int? PartDuration { get; set; }

        /// <summary>
        /// <para>The live streaming protocol and container format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HLS_CMAF</b></para>
        /// </description></item>
        /// <item><description><para><b>LLHLS_TS</b>
        /// (low latency)</para>
        /// </description></item>
        /// <item><description><para><b>LLHLS_CMAF</b> (low latency)</para>
        /// </description></item>
        /// <item><description><para><b>DASH_CMAF</b></para>
        /// </description></item>
        /// <item><description><para><b>HLSDASH_CMAF</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HLS_CMAF</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The segment length, in seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set Protocol to HLS_CMAF, the valid values are 1 to 10. The default value is 5.</para>
        /// </description></item>
        /// <item><description><para>If you set Protocol to LLHLS_\*, the valid values are 1 to 2. The default value is 1.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SegmentDuration")]
        [Validation(Required=false)]
        public int? SegmentDuration { get; set; }

        /// <summary>
        /// <para>The number of M3U8 segments for live streaming.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values: 3 to 10.</para>
        /// </description></item>
        /// <item><description><para>Default value: 3.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SegmentNum")]
        [Validation(Required=false)]
        public int? SegmentNum { get; set; }

        /// <summary>
        /// <para>The StreamName must match the StreamName in the ingest URL for the template to take effect. The StreamName can be up to 255 characters in length and can contain digits, uppercase letters, lowercase letters, hyphens (-), and underscores (_). A hyphen or an underscore cannot be the first character. You can also set this parameter to a single asterisk (\*) to match all StreamNames.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StreamName</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
