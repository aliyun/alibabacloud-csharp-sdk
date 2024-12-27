// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class GetTagValRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a timestamp that is accurate to milliseconds.</para>
        /// <remarks>
        /// <para> This value is of the LONG type, and precision loss may occur during serialization or deserialization. Do not set this parameter to a value greater than 9007199254740991.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1575622455686</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appTest</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The name of the span.</para>
        /// 
        /// <b>Example:</b>
        /// <para>createOrder</para>
        /// </summary>
        [NameInMap("SpanName")]
        [Validation(Required=false)]
        public string SpanName { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a timestamp that is accurate to milliseconds.</para>
        /// <remarks>
        /// <para> This value is of the LONG type, and precision loss may occur during serialization or deserialization. Do not set this parameter to a value greater than 9007199254740991.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1575561600000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The tag key.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2399667.html">GetTagKey</a> operation to obtain a tag key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>span.kind</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

    }

}
