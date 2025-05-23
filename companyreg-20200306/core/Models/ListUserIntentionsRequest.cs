// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class ListUserIntentionsRequest : TeaModel {
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>esp.companyreg_cloud</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>esp.bookkeeping,esp.bookkeeping_cloud</para>
        /// </summary>
        [NameInMap("BizTypes")]
        [Validation(Required=false)]
        public string BizTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>I20210917170147000001</para>
        /// </summary>
        [NameInMap("IntentionBizId")]
        [Validation(Required=false)]
        public string IntentionBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UpdateTime</para>
        /// </summary>
        [NameInMap("SortFiled")]
        [Validation(Required=false)]
        public string SortFiled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>37</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("WithExtInfo")]
        [Validation(Required=false)]
        public bool? WithExtInfo { get; set; }

    }

}
