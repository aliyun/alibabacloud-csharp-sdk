// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertActionsRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier for the action integration.</para>
        /// </summary>
        [NameInMap("alertActionIds")]
        [Validation(Required=false)]
        public List<string> AlertActionIds { get; set; }

        /// <summary>
        /// <para>Name of the action integration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("alertActionName")]
        [Validation(Required=false)]
        public string AlertActionName { get; set; }

        /// <summary>
        /// <para>Page number. Default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size. Default is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Type of the action integration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
