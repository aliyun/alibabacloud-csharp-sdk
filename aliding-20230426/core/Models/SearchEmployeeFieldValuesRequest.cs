// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SearchEmployeeFieldValuesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>APP_PBKxxx</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-05-01</para>
        /// </summary>
        [NameInMap("CreateFromTimeGMT")]
        [Validation(Required=false)]
        public string CreateFromTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-05-01</para>
        /// </summary>
        [NameInMap("CreateToTimeGMT")]
        [Validation(Required=false)]
        public string CreateToTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FORM-EF6Yxxx</para>
        /// </summary>
        [NameInMap("FormUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-05-01</para>
        /// </summary>
        [NameInMap("ModifiedFromTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedFromTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-09-10</para>
        /// </summary>
        [NameInMap("ModifiedToTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedToTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>112212221</para>
        /// </summary>
        [NameInMap("OriginatorId")]
        [Validation(Required=false)]
        public string OriginatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;textField_annandfa\&quot;:\&quot;1212\&quot;}</para>
        /// </summary>
        [NameInMap("SearchFieldJson")]
        [Validation(Required=false)]
        public string SearchFieldJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hexxxx</para>
        /// </summary>
        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;textField_xahdfna\&quot;]</para>
        /// </summary>
        [NameInMap("TargetFieldJson")]
        [Validation(Required=false)]
        public string TargetFieldJson { get; set; }

    }

}
