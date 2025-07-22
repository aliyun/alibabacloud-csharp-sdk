// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateEcdReportTaskRequest : TeaModel {
        [NameInMap("FilterList")]
        [Validation(Required=false)]
        public List<CreateEcdReportTaskRequestFilterList> FilterList { get; set; }
        public class CreateEcdReportTaskRequestFilterList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Tag:TestKey</para>
            /// </summary>
            [NameInMap("FilterKey")]
            [Validation(Required=false)]
            public string FilterKey { get; set; }

            [NameInMap("FilterValues")]
            [Validation(Required=false)]
            public List<string> FilterValues { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("LangType")]
        [Validation(Required=false)]
        public string LangType { get; set; }

        [NameInMap("ReportFileName")]
        [Validation(Required=false)]
        public string ReportFileName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESKTOP</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RESOURCE_REPORT</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
