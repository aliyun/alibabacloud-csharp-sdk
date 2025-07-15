// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLivePackageConfigRequest : TeaModel {
        /// <summary>
        /// <para>The application name. The value of this parameter must be the same as the application name that is specified in the ingest URL. Otherwise, the configuration does not take effect. The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (<em>). The name cannot start with a hyphen (-) or underscore (</em>). You can also specify an asterisk (\*) as the value to match all applications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppName</para>
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
        /// <para>Specifies whether to ignore the transcoded stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <para>The part length. Unit: milliseconds.</para>
        /// <remarks>
        /// <para> This parameter is required if Protocol is set to LLHLS_TS or LLHLS_CMAF.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the value of SegmentDuration is 1, the valid values of this parameter are 100 to 500.</description></item>
        /// <item><description>If the value of SegmentDuration is 2, the valid values of this parameter are 100 to 1000.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>350</para>
        /// </summary>
        [NameInMap("PartDuration")]
        [Validation(Required=false)]
        public int? PartDuration { get; set; }

        /// <summary>
        /// <para>The streaming protocol and encapsulation format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HLS_CMAF</b></description></item>
        /// <item><description><b>LLHLS_TS</b> (low latency)</description></item>
        /// <item><description><b>LLHLS_CMAF</b> (low latency)</description></item>
        /// <item><description><b>DASH_CMAF</b></description></item>
        /// <item><description><b>HLSDASH_CMAF</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HLS_CMAF</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The segment length. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>If Protocol is set to HLS_CMAF, the valid values of this parameter are 1 to 10.</description></item>
        /// <item><description>If Protocol is set to LLHLS_TS or LLHLS_CMAF, the valid values of this parameter are 1 to 2.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SegmentDuration")]
        [Validation(Required=false)]
        public int? SegmentDuration { get; set; }

        /// <summary>
        /// <para>The number of segments. Valid values: 3 to 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SegmentNum")]
        [Validation(Required=false)]
        public int? SegmentNum { get; set; }

        /// <summary>
        /// <para>The stream name. The value of this parameter must be the same as the stream name that is specified in the ingest URL. Otherwise, the configuration does not take effect. The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (<em>). The name cannot start with a hyphen (-) or underscore (</em>). You can also specify an asterisk (\*) as the value to match all streams.</para>
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
