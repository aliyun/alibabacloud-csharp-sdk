// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitDynamicChartJobRequest : TeaModel {
        /// <summary>
        /// <para>The axis style settings. If <c>XAxisFontInterval</c> is not specified or is set to 0, the system automatically calculates the interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FontFile&quot;:&quot;Microsoft YaHei&quot;,&quot;XAxisFontSize&quot;:&quot;30&quot;,&quot;YAxisFontSize&quot;:&quot;30&quot;,&quot;XAxisFontInterval&quot;:&quot;30&quot;,&quot;AxisColor&quot;:&quot;30&quot;}</para>
        /// </summary>
        [NameInMap("AxisParams")]
        [Validation(Required=false)]
        public string AxisParams { get; set; }

        /// <summary>
        /// <para>The settings for the chart background. You can specify a Background Color or a Background Image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Color&quot;:&quot;#000000&quot;,&quot;ImageUrl&quot;:&quot;<a href="http://your-bucket.oss-cn-shanghai.aliyuncs.com/obj.jpg%22%7D">http://your-bucket.oss-cn-shanghai.aliyuncs.com/obj.jpg&quot;}</a></para>
        /// </summary>
        [NameInMap("Background")]
        [Validation(Required=false)]
        public string Background { get; set; }

        /// <summary>
        /// <para>The overall configuration for the chart\&quot;s appearance and timing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Style&quot;:&quot;Normal&quot;,&quot;TitleStartTime&quot;:&quot;3000&quot;,&quot;ChartStartTime&quot;:&quot;3000&quot;,&quot;VideoDuration&quot;:&quot;15000&quot;}</para>
        /// </summary>
        [NameInMap("ChartConfig")]
        [Validation(Required=false)]
        public string ChartConfig { get; set; }

        /// <summary>
        /// <para>The chart title settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Text&quot;:&quot; primary title&quot;,&quot;FontSize&quot;:&quot;30&quot;,&quot;FontColor&quot;:&quot;#000000&quot;,&quot;FontFile&quot;:&quot;Microsoft YaHei&quot;}</para>
        /// </summary>
        [NameInMap("ChartTitle")]
        [Validation(Required=false)]
        public string ChartTitle { get; set; }

        /// <summary>
        /// <para>The chart type to generate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Line</para>
        /// </summary>
        [NameInMap("ChartType")]
        [Validation(Required=false)]
        public string ChartType { get; set; }

        /// <summary>
        /// <para>The data source label settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Text&quot;:&quot;Data source&quot;,&quot;FontSize&quot;:&quot;30&quot;,&quot;FontColor&quot;:&quot;#000000&quot;,&quot;FontFile&quot;:&quot;Microsoft YaHei&quot;}</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// <para>The job description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The input data configuration, which specifies the Excel file location.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;XlsFile&quot;:&quot;<a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/obj.xls%22%7D">https://your-bucket.oss-cn-shanghai.aliyuncs.com/obj.xls&quot;}</a></para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The output video configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MediaURL&quot;:&quot;<a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/obj.mp4%22,%22Bitrate%22:2000,%22Width%22:800,%22Height%22:680%7D">https://your-bucket.oss-cn-shanghai.aliyuncs.com/obj.mp4&quot;,&quot;Bitrate&quot;:2000,&quot;Width&quot;:800,&quot;Height&quot;:680}</a></para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <para>The subtitle settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Text&quot;:&quot;Subtitle&quot;,&quot;FontSize&quot;:&quot;30&quot;,&quot;FontColor&quot;:&quot;#000000&quot;,&quot;FontFile&quot;:&quot;Microsoft YaHei&quot;}</para>
        /// </summary>
        [NameInMap("Subtitle")]
        [Validation(Required=false)]
        public string Subtitle { get; set; }

        /// <summary>
        /// <para>The job title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The data unit label settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Text&quot;:&quot;Unit&quot;,&quot;FontSize&quot;:&quot;30&quot;,&quot;FontColor&quot;:&quot;#000000&quot;,&quot;FontFile&quot;:&quot;Microsoft YaHei&quot;}</para>
        /// </summary>
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        /// <summary>
        /// <para>The custom user data in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;user&quot;:&quot;data&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
