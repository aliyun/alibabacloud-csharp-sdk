// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitDynamicChartJobRequest : TeaModel {
        [NameInMap("AxisParams")]
        [Validation(Required=false)]
        public string AxisParams { get; set; }

        [NameInMap("Background")]
        [Validation(Required=false)]
        public string Background { get; set; }

        [NameInMap("ChartConfig")]
        [Validation(Required=false)]
        public string ChartConfig { get; set; }

        [NameInMap("ChartTitle")]
        [Validation(Required=false)]
        public string ChartTitle { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChartType")]
        [Validation(Required=false)]
        public string ChartType { get; set; }

        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        [NameInMap("Subtitle")]
        [Validation(Required=false)]
        public string Subtitle { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
