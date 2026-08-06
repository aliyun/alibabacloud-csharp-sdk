// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateCrawlerRequest : TeaModel {
        [NameInMap("EnableAiComment")]
        [Validation(Required=false)]
        public bool? EnableAiComment { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Serverless_res_group_1234567890123456_1234567890</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public UpdateCrawlerRequestScheduleConfig ScheduleConfig { get; set; }
        public class UpdateCrawlerRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0 0 2 ? * *</para>
            /// </summary>
            [NameInMap("CronExpress")]
            [Validation(Required=false)]
            public string CronExpress { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public UpdateCrawlerRequestScope Scope { get; set; }
        public class UpdateCrawlerRequestScope : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>^tmp_.*</para>
            /// </summary>
            [NameInMap("ExcludeRegex")]
            [Validation(Required=false)]
            public string ExcludeRegex { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<string> Items { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATABASE</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

    }

}
