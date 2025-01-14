// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAlertRulesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>error_rule</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account used by the owner of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1933790683****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account used by the alert recipient.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1933790683****</para>
        /// </summary>
        [NameInMap("Receiver")]
        [Validation(Required=false)]
        public string Receiver { get; set; }

        /// <summary>
        /// <para>The IDs of the scheduling tasks.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<long?> TaskIds { get; set; }

        /// <summary>
        /// <para>The alert triggering condition.</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}
