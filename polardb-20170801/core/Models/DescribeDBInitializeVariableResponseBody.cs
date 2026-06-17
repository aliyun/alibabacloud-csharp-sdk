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
        /// <item><description><para>Oracle</para>
        /// </description></item>
        /// <item><description><para>PostgreSQL</para>
        /// </description></item>
        /// <item><description><para>MySQL</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostgreSQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The database version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>475F58B7-F394-4394-AA6E-4F1CBA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Variables")]
        [Validation(Required=false)]
        public DescribeDBInitializeVariableResponseBodyVariables Variables { get; set; }
        public class DescribeDBInitializeVariableResponseBodyVariables : TeaModel {
            [NameInMap("Variable")]
            [Validation(Required=false)]
            public List<DescribeDBInitializeVariableResponseBodyVariablesVariable> Variable { get; set; }
            public class DescribeDBInitializeVariableResponseBodyVariablesVariable : TeaModel {
                [NameInMap("Charset")]
                [Validation(Required=false)]
                public string Charset { get; set; }

                [NameInMap("Collate")]
                [Validation(Required=false)]
                public string Collate { get; set; }

                [NameInMap("Ctype")]
                [Validation(Required=false)]
                public string Ctype { get; set; }

            }

        }

    }

}
