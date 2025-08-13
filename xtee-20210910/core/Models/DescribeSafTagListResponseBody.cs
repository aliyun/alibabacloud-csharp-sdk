// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafTagListResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Page size, default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSafTagListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSafTagListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Tag description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>依赖IP画像模型识别输出风险高、中高、中的判定\n数据来源主要基于IP的网络属性数据和对黑产行为轨迹的情报监控数据，涵盖可识别检测IP网络属性特征、恶意属性等特征\n而模型评分的高中低主要是根据当前IP号段命中风险行为的恶意程度和种类来判定的\n备注：以下rn0311、rn0312、rn0313、rn0314、rn0315属于IP画像模型针对当前请求IP识别出的风险类别</para>
            /// </summary>
            [NameInMap("tagDesc")]
            [Validation(Required=false)]
            public string TagDesc { get; set; }

            /// <summary>
            /// <para>Tag meaning.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IP风险评分高</para>
            /// </summary>
            [NameInMap("tagMean")]
            [Validation(Required=false)]
            public string TagMean { get; set; }

            /// <summary>
            /// <para>Tag name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rn0301</para>
            /// </summary>
            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// <para>Tag identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rn0301</para>
            /// </summary>
            [NameInMap("tagState")]
            [Validation(Required=false)]
            public string TagState { get; set; }

            /// <summary>
            /// <para>Tag type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IP风险类</para>
            /// </summary>
            [NameInMap("tagType")]
            [Validation(Required=false)]
            public string TagType { get; set; }

            /// <summary>
            /// <para>Unique identifier of the tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rn0301</para>
            /// </summary>
            [NameInMap("tagUid")]
            [Validation(Required=false)]
            public string TagUid { get; set; }

            /// <summary>
            /// <para>Update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684744034000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
