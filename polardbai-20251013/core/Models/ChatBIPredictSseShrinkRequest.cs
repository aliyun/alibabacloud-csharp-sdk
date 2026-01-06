// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class ChatBIPredictSseShrinkRequest : TeaModel {
        [NameInMap("AuthMessage")]
        [Validation(Required=false)]
        public string AuthMessage { get; set; }

        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_test</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GenerateChart")]
        [Validation(Required=false)]
        public bool? GenerateChart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GenerateSummary")]
        [Validation(Required=false)]
        public bool? GenerateSummary { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze7smdi2f*******</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>空字符串, pattern_index_1</para>
        /// </summary>
        [NameInMap("PatternIndexTableName")]
        [Validation(Required=false)]
        public string PatternIndexTableName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>查询2023年10月1日至2023年10月3日期间开课的课程名称和上课地点。</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>schema_index_1</para>
        /// </summary>
        [NameInMap("SchemaIndexTableName")]
        [Validation(Required=false)]
        public string SchemaIndexTableName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SelectData")]
        [Validation(Required=false)]
        public bool? SelectData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ThinkingMode")]
        [Validation(Required=false)]
        public bool? ThinkingMode { get; set; }

    }

}
