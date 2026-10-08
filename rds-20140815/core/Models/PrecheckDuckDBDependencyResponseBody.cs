// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class PrecheckDuckDBDependencyResponseBody : TeaModel {
        /// <summary>
        /// <para>The items that do not meet the prerequisites for creating a DuckDB-based analytical instance.</para>
        /// </summary>
        [NameInMap("FailedCheckItems")]
        [Validation(Required=false)]
        public List<PrecheckDuckDBDependencyResponseBodyFailedCheckItems> FailedCheckItems { get; set; }
        public class PrecheckDuckDBDependencyResponseBodyFailedCheckItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether the item can be fixed with one click.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The item can be fixed with one click by calling the <a href="https://help.aliyun.com/document_detail/2623684.html">ModifyDBInstanceConfig</a> operation.</description></item>
            /// <item><description><b>false</b>: The item cannot be fixed with one click.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: If the major engine version of the database instance does not meet the requirements, you must perform a <a href="https://help.aliyun.com/document_detail/2623684.html">manual upgrade</a>.</para>
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
            /// <para>The target value or target range of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17.0</para>
            /// </summary>
            [NameInMap("RequiredValue")]
            [Validation(Required=false)]
            public string RequiredValue { get; set; }

            /// <summary>
            /// <para>The check item type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Parameter</b>: parameter.</description></item>
            /// <item><description><b>MinorVersion</b>: minor engine version.</description></item>
            /// <item><description><b>MajorVersion</b>: major engine version.</description></item>
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
        /// <para>Indicates whether the prerequisite check for creating a DuckDB-based analytical instance is passed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The check is passed.</description></item>
        /// <item><description><b>false</b>: The check is not passed.</description></item>
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
