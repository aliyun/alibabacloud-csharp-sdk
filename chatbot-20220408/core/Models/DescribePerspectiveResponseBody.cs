// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribePerspectiveResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-07-27T07:05:37Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-07-26T07:05:37Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>移动端视角</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FZJBY3raWr</para>
        /// </summary>
        [NameInMap("PerspectiveCode")]
        [Validation(Required=false)]
        public string PerspectiveCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3001</para>
        /// </summary>
        [NameInMap("PerspectiveId")]
        [Validation(Required=false)]
        public string PerspectiveId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F285D735-D580-18A8-B97F-B2E72B00F101</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SelfDefine")]
        [Validation(Required=false)]
        public bool? SelfDefine { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
