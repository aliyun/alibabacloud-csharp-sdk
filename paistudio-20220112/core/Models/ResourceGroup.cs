// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ResourceGroup : TeaModel {
        /// <summary>
        /// <para>CreatorID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1612285282502324</para>
        /// </summary>
        [NameInMap("CreatorID")]
        [Validation(Required=false)]
        public string CreatorID { get; set; }

        /// <summary>
        /// <para>pai resource created time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        /// <summary>
        /// <para>GmtModified</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>pai resource group name</para>
        /// 
        /// <b>Example:</b>
        /// <para>RG1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>NodeCount</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// <para>pai resource group id</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg17tmvwiokhzaxg</para>
        /// </summary>
        [NameInMap("ResourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>UserVpc</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>pworkspace id</para>
        /// 
        /// <b>Example:</b>
        /// <para>23000</para>
        /// </summary>
        [NameInMap("WorkspaceID")]
        [Validation(Required=false)]
        public string WorkspaceID { get; set; }

    }

}
