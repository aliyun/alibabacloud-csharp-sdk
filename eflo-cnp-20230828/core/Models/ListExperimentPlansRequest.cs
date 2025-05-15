// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class ListExperimentPlansRequest : TeaModel {
        /// <summary>
        /// <para>Creation Time Sorting Rule</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("CreatTimeOrder")]
        [Validation(Required=false)]
        public string CreatTimeOrder { get; set; }

        /// <summary>
        /// <para>End Time Sorting Rule</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("EndTimeOrder")]
        [Validation(Required=false)]
        public string EndTimeOrder { get; set; }

        /// <summary>
        /// <para>Page Number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>Execution Status</para>
        /// </summary>
        [NameInMap("PlanTaskStatus")]
        [Validation(Required=false)]
        public List<string> PlanTaskStatus { get; set; }

        /// <summary>
        /// <para>Resource Group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzij65sf2rr5i</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Resource ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>189</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public long? ResourceId { get; set; }

        /// <summary>
        /// <para>Resource</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public List<string> ResourceName { get; set; }

        /// <summary>
        /// <para>Number of Items</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>Start Time Sorting Rule</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("StartTimeOrder")]
        [Validation(Required=false)]
        public string StartTimeOrder { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListExperimentPlansRequestTag> Tag { get; set; }
        public class ListExperimentPlansRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>owner</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag value</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Template Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
