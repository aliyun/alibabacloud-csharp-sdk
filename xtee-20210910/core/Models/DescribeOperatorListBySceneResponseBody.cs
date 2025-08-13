// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeOperatorListBySceneResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeOperatorListBySceneResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeOperatorListBySceneResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Return value type</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            /// <summary>
            /// <para>Operator list</para>
            /// </summary>
            [NameInMap("operators")]
            [Validation(Required=false)]
            public List<DescribeOperatorListBySceneResponseBodyResultObjectOperators> Operators { get; set; }
            public class DescribeOperatorListBySceneResponseBodyResultObjectOperators : TeaModel {
                /// <summary>
                /// <para>Operator code</para>
                /// 
                /// <b>Example:</b>
                /// <para>equals</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Whether it contains a right variable</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("hasRightVariable")]
                [Validation(Required=false)]
                public bool? HasRightVariable { get; set; }

                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>等于</para>
                /// </summary>
                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <para>Operator name</para>
                /// 
                /// <b>Example:</b>
                /// <para>等于</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Right variable object</para>
                /// </summary>
                [NameInMap("rightVariables")]
                [Validation(Required=false)]
                public List<DescribeOperatorListBySceneResponseBodyResultObjectOperatorsRightVariables> RightVariables { get; set; }
                public class DescribeOperatorListBySceneResponseBodyResultObjectOperatorsRightVariables : TeaModel {
                    /// <summary>
                    /// <para>Field name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>年龄</para>
                    /// </summary>
                    [NameInMap("fieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    /// <summary>
                    /// <para>Field type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>INT</para>
                    /// </summary>
                    [NameInMap("fieldType")]
                    [Validation(Required=false)]
                    public string FieldType { get; set; }

                    /// <summary>
                    /// <para>Field value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("fieldValue")]
                    [Validation(Required=false)]
                    public string FieldValue { get; set; }

                }

            }

        }

    }

}
