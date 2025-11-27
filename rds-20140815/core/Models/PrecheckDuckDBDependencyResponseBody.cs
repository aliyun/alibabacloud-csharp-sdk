// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class PrecheckDuckDBDependencyResponseBody : TeaModel {
        /// <summary>
        /// <para>The check items that do not meet the requirements for creating DuckDB-based analytical instances.</para>
        /// </summary>
        [NameInMap("FailedCheckItems")]
        [Validation(Required=false)]
        public List<PrecheckDuckDBDependencyResponseBodyFailedCheckItems> FailedCheckItems { get; set; }
        public class PrecheckDuckDBDependencyResponseBodyFailedCheckItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether the item can be changed with one click to meet the requirements.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes. You can call the <a href="https://help.aliyun.com/document_detail/2623684.html">ModifyDBInstanceConfig</a> operation to change the item with one click.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the major engine version of the primary does not meet the requirements, you must manually upgrade it.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowAutoModify")]
            [Validation(Required=false)]
            public bool? AllowAutoModify { get; set; }

            /// <summary>
            /// <para>The current value of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15.0</para>
            /// </summary>
            [NameInMap("CurrentValue")]
            [Validation(Required=false)]
            public string CurrentValue { get; set; }

            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MajorVersion</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value or value range that meets the requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17.0</para>
            /// </summary>
            [NameInMap("RequiredValue")]
            [Validation(Required=false)]
            public string RequiredValue { get; set; }

            /// <summary>
            /// <para>The check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Parameter</b>: The parameters of the primary instance.</description></item>
            /// <item><description><b>MinorVersion</b>: The minor engine version of the primary instance.</description></item>
            /// <item><description><b>MajorVersion</b>: The major engine version of the primary instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Parameter</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the primary instance meet the requirements for creating DuckDB-based analytical instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
