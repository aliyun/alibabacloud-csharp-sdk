// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class SetFingerPrintTemplateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>347431a9-90f6-448e-82c4-42bc84a9****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAAAAAAAAAA</para>
        /// </summary>
        [NameInMap("EncryptedFingerPrintTemplate")]
        [Validation(Required=false)]
        public string EncryptedFingerPrintTemplate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>drjfspchj</para>
        /// </summary>
        [NameInMap("EncryptedKey")]
        [Validation(Required=false)]
        public string EncryptedKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>goG3gG8AAABhujtscn</para>
        /// </summary>
        [NameInMap("FingerPrintTemplate")]
        [Validation(Required=false)]
        public string FingerPrintTemplate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v11c73e7af0cb43ff39301651142485099ffb447085d76c4147519dbaa21c3bd90d53045e327c1f525ee6331c52556****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>As53328794</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8b42538a-246e-45a1-95ea-e5c65b09****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
