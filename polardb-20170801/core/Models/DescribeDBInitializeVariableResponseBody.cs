// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBInitializeVariableResponseBody : TeaModel {
        /// <summary>
        /// <para>The database type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Oracle</description></item>
        /// <item><description>PostgreSQL</description></item>
        /// <item><description>MySQL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostgreSQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>475F58B7-F394-4394-AA6E-4F1CBA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The attributes that are returned.</para>
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public DescribeDBInitializeVariableResponseBodyVariables Variables { get; set; }
        public class DescribeDBInitializeVariableResponseBodyVariables : TeaModel {
            [NameInMap("Variable")]
            [Validation(Required=false)]
            public List<DescribeDBInitializeVariableResponseBodyVariablesVariable> Variable { get; set; }
            public class DescribeDBInitializeVariableResponseBodyVariablesVariable : TeaModel {
                /// <summary>
                /// <para>The character set that is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EUC_CN</para>
                /// </summary>
                [NameInMap("Charset")]
                [Validation(Required=false)]
                public string Charset { get; set; }

                /// <summary>
                /// <para>The language that indicates the collation of the databases that are created.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>The language must be compatible with the character set that is specified by <b>CharacterSetName</b>.</description></item>
                /// <item><description>This parameter is required for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.</description></item>
                /// <item><description>This parameter is optional for PolarDB for MySQL clusters.</description></item>
                /// </list>
                /// </remarks>
                /// <para>To view the valid values for this parameter, perform the following steps: Log on to the PolarDB console and click the ID of a cluster. In the left-side navigation pane, choose <b>Settings and Management</b> &gt; <b>Databases</b>. Then, click <b>Create Database</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C</para>
                /// </summary>
                [NameInMap("Collate")]
                [Validation(Required=false)]
                public string Collate { get; set; }

                /// <summary>
                /// <para>The language that indicates the character type of the database.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>The language must be compatible with the character set that is specified by <b>CharacterSetName</b>.</para>
                /// </description></item>
                /// <item><description><para>The specified parameter value must be the same as the value of <b>Collate</b>.</para>
                /// </description></item>
                /// <item><description><para>If the PolarDB cluster runs PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL, this parameter is required. If the cluster runs PolarDB for MySQL, this parameter is not supported.</para>
                /// </description></item>
                /// </list>
                /// <para>To view the valid values of this parameter, perform the following steps: First, log on to the PolarDB console and click the ID of a cluster. Then, in the left-side navigation pane, choose <b>Settings and Management</b> &gt; <b>Databases</b>. Finally, click <b>Create Database</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C</para>
                /// </summary>
                [NameInMap("Ctype")]
                [Validation(Required=false)]
                public string Ctype { get; set; }

            }

        }

    }

}
