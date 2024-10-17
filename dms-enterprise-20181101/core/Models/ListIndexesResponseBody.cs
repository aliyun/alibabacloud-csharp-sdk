// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListIndexesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details of indexes.</para>
        /// </summary>
        [NameInMap("IndexList")]
        [Validation(Required=false)]
        public ListIndexesResponseBodyIndexList IndexList { get; set; }
        public class ListIndexesResponseBodyIndexList : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public List<ListIndexesResponseBodyIndexListIndex> Index { get; set; }
            public class ListIndexesResponseBodyIndexListIndex : TeaModel {
                /// <summary>
                /// <para>The description of the index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("IndexComment")]
                [Validation(Required=false)]
                public string IndexComment { get; set; }

                /// <summary>
                /// <para>The ID of the index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IndexId")]
                [Validation(Required=false)]
                public string IndexId { get; set; }

                /// <summary>
                /// <para>The name of the index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idx_test</para>
                /// </summary>
                [NameInMap("IndexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                /// <summary>
                /// <para>The type of the index. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Primary</description></item>
                /// <item><description>Unique</description></item>
                /// <item><description>Normal</description></item>
                /// <item><description>FullText</description></item>
                /// <item><description>Spatial</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("IndexType")]
                [Validation(Required=false)]
                public string IndexType { get; set; }

                /// <summary>
                /// <para>The ID of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1F4DE2F1-5B47-462A-A973-E02EB7AF386B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
