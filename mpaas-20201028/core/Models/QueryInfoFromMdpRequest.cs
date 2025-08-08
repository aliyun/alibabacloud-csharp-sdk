// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryInfoFromMdpRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIPUBE5C3F6D091419</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13178195662</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2fe6e5fa754be73d1721b9bd2c6cf821</para>
        /// </summary>
        [NameInMap("MobileMd5")]
        [Validation(Required=false)]
        public string MobileMd5 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>db0797452ccafce84d7c151eb81596099bda3f097693d1e18b588804e6742ced</para>
        /// </summary>
        [NameInMap("MobileSha256")]
        [Validation(Required=false)]
        public string MobileSha256 { get; set; }

        [NameInMap("MobileSm3")]
        [Validation(Required=false)]
        public string MobileSm3 { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RiskScene")]
        [Validation(Required=false)]
        public string RiskScene { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
