// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddTrancodeSEIRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. You can view the application name on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page of the ApsaraVideo Live console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The time period after which the SEI is inserted after the request is received. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Delay")]
        [Validation(Required=false)]
        public int? Delay { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to append the SEI to each keyframe or frame. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>keyframe</b></description></item>
        /// <item><description><b>frame</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>keyframe</para>
        /// </summary>
        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of times that the SEI is repeatedly inserted. A value of -1 specifies infinite times.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Repeat")]
        [Validation(Required=false)]
        public int? Repeat { get; set; }

        /// <summary>
        /// <para>The name of the live stream.</para>
        /// <remarks>
        /// <para> The value of this parameter must be the name of the source stream. This way, the SEI is inserted to all the transcoded streams.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The SEI text. It can be up to 4,000 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveSei****</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
