// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartViewShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eo85****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The global background color.</para>
        /// </summary>
        [NameInMap("BgColor")]
        [Validation(Required=false)]
        public StartViewShrinkRequestBgColor BgColor { get; set; }
        public class StartViewShrinkRequestBgColor : TeaModel {
            /// <summary>
            /// <para>The B value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("B")]
            [Validation(Required=false)]
            public int? B { get; set; }

            /// <summary>
            /// <para>The G value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("G")]
            [Validation(Required=false)]
            public int? G { get; set; }

            /// <summary>
            /// <para>The R value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("R")]
            [Validation(Required=false)]
            public int? R { get; set; }

        }

        /// <summary>
        /// <para>The ID of an existing channel. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The crop mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: proportional cropping</description></item>
        /// <item><description><b>2</b>: proportional padding (default)</description></item>
        /// <item><description><b>3</b>: stretch to fill</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CropMode")]
        [Validation(Required=false)]
        public int? CropMode { get; set; }

        /// <summary>
        /// <para>The global pane background color.</para>
        /// </summary>
        [NameInMap("RegionColor")]
        [Validation(Required=false)]
        public StartViewShrinkRequestRegionColor RegionColor { get; set; }
        public class StartViewShrinkRequestRegionColor : TeaModel {
            /// <summary>
            /// <para>The B value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("B")]
            [Validation(Required=false)]
            public int? B { get; set; }

            /// <summary>
            /// <para>The G value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("G")]
            [Validation(Required=false)]
            public int? G { get; set; }

            /// <summary>
            /// <para>The R value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255</para>
            /// </summary>
            [NameInMap("R")]
            [Validation(Required=false)]
            public int? R { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to allow starting the task when the channel does not exist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No (default).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("StartWithoutChannel")]
        [Validation(Required=false)]
        public bool? StartWithoutChannel { get; set; }

        /// <summary>
        /// <para>The wait time for the task when the channel is not started, in seconds. This parameter is valid only when the StartWithoutChannel parameter is set to true. Valid values: 30 to 120.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("StartWithoutChannelWaitTime")]
        [Validation(Required=false)]
        public int? StartWithoutChannelWaitTime { get; set; }

        /// <summary>
        /// <para>The task ID for the current request. Only a single ID is supported. The ID can contain letters, digits, underscores (_), and hyphens (-), and can be up to 55 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>567</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The stream property. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>main: main stream</description></item>
        /// <item><description>screen-cast: shared stream</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("ViewContent")]
        [Validation(Required=false)]
        public string ViewContent { get; set; }

        /// <summary>
        /// <para>The list of user IDs of Session Initiation Protocol (SIP) devices that are allowed to view the main stream or shared stream.</para>
        /// </summary>
        [NameInMap("ViewSubscribers")]
        [Validation(Required=false)]
        public string ViewSubscribersShrink { get; set; }

    }

}
