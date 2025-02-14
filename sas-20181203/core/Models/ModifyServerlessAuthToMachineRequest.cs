// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyServerlessAuthToMachineRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>**7ad7e3a</para>
        /// </summary>
        [NameInMap("AppCriteria")]
        [Validation(Required=false)]
        public string AppCriteria { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SERVERLESS</para>
        /// </summary>
        [NameInMap("AuthItem")]
        [Validation(Required=false)]
        public string AuthItem { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BindAll")]
        [Validation(Required=false)]
        public bool? BindAll { get; set; }

        [NameInMap("BindAppList")]
        [Validation(Required=false)]
        public List<string> BindAppList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("BindAssetType")]
        [Validation(Required=false)]
        public string BindAssetType { get; set; }

        [NameInMap("BindUuidList")]
        [Validation(Required=false)]
        public List<string> BindUuidList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;vulStatus&quot;,&quot;value&quot;:&quot;YES&quot;,&quot;logicalExp&quot;:&quot;AND&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>level2</para>
        /// </summary>
        [NameInMap("NtmVersion")]
        [Validation(Required=false)]
        public string NtmVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PreBind")]
        [Validation(Required=false)]
        public int? PreBind { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>233016**0482</para>
        /// </summary>
        [NameInMap("PreBindOrderId")]
        [Validation(Required=false)]
        public long? PreBindOrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ResourceDirectoryUid")]
        [Validation(Required=false)]
        public long? ResourceDirectoryUid { get; set; }

        [NameInMap("UnBindAppList")]
        [Validation(Required=false)]
        public List<string> UnBindAppList { get; set; }

        [NameInMap("UnBindUuidList")]
        [Validation(Required=false)]
        public List<string> UnBindUuidList { get; set; }

    }

}
