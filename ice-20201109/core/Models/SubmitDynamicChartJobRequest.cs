// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitDynamicChartJobRequest : TeaModel {
        /// <summary>
        /// 坐标样式。XAxisFontInterval不传或为0则算法自动计算间距
        /// </summary>
        [NameInMap("AxisParams")]
        [Validation(Required=false)]
        public string AxisParams { get; set; }

        /// <summary>
        /// 图表背景
        /// </summary>
        [NameInMap("Background")]
        [Validation(Required=false)]
        public string Background { get; set; }

        /// <summary>
        /// 图表配置
        /// </summary>
        [NameInMap("ChartConfig")]
        [Validation(Required=false)]
        public string ChartConfig { get; set; }

        /// <summary>
        /// 主标题
        /// </summary>
        [NameInMap("ChartTitle")]
        [Validation(Required=false)]
        public string ChartTitle { get; set; }

        /// <summary>
        /// 图表类型
        /// </summary>
        [NameInMap("ChartType")]
        [Validation(Required=false)]
        public string ChartType { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 图表输入数据
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// 输出设置
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [NameInMap("Subtitle")]
        [Validation(Required=false)]
        public string Subtitle { get; set; }

        /// <summary>
        /// 任务标题
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        /// <summary>
        /// 自定义数据，JSON格式
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
