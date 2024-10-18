// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListApplicationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>createdByMe</para>
        /// </summary>
        [NameInMap("AppFilter")]
        [Validation(Required=false)]
        public string AppFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>keyword</para>
        /// </summary>
        [NameInMap("AppNameSearchKeyword")]
        [Validation(Required=false)]
        public string AppNameSearchKeyword { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>corpid</para>
        /// </summary>
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>keyword</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>keyword</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>keyword</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
