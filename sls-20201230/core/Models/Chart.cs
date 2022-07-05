// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Chart : TeaModel {
        /// <summary>
        /// action
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public Dictionary<string, string> Action { get; set; }

        /// <summary>
        /// 图表的显示配置
        /// </summary>
        [NameInMap("display")]
        [Validation(Required=false)]
        public ChartDisplay Display { get; set; }
        public class ChartDisplay : TeaModel {
            [NameInMap("height")]
            [Validation(Required=false)]
            public long? Height { get; set; }
            [NameInMap("width")]
            [Validation(Required=false)]
            public long? Width { get; set; }
            [NameInMap("xAxis")]
            [Validation(Required=false)]
            public List<string> XAxis { get; set; }
            [NameInMap("xPos")]
            [Validation(Required=false)]
            public long? XPos { get; set; }
            [NameInMap("yAxis")]
            [Validation(Required=false)]
            public List<string> YAxis { get; set; }
            [NameInMap("yPos")]
            [Validation(Required=false)]
            public long? YPos { get; set; }
        };

        /// <summary>
        /// 查询配置
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public ChartSearch Search { get; set; }
        public class ChartSearch : TeaModel {
            [NameInMap("end")]
            [Validation(Required=false)]
            public string End { get; set; }
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }
            [NameInMap("start")]
            [Validation(Required=false)]
            public string Start { get; set; }
            [NameInMap("topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
        };

        /// <summary>
        /// 图表标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 图标类型
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
