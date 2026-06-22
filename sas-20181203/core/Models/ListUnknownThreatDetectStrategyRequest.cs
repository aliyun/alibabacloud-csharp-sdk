// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnknownThreatDetectStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The page number for a paginated query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The strategy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The strategy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>strategy****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The whitelist mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>hash</b>: process hash</para>
        /// </description></item>
        /// <item><description><para><b>path</b>: process path</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hash</para>
        /// </summary>
        [NameInMap("StudyMode")]
        [Validation(Required=false)]
        public string StudyMode { get; set; }

    }

}
