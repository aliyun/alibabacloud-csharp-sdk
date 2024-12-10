// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetVulItemPageRequest : TeaModel {
        /// <summary>
        /// <para>Vulnerability alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RHSA-2018:3665-Important: NetworkManager security update</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Processing status. y: processed; n: unprocessed; h: processing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>Risk level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>later</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>Vulnerability name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oval:com.redhat.rhsa:def:20183665</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Number of items to display per page in the returned data.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Vulnerability type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

    }

}
