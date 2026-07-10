// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InsertWhiteListSettingRequest : TeaModel {
        /// <summary>
        /// <para>The certificate number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330103xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        /// <summary>
        /// <para>The unique identifier of the ID Verification request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shsf57a4e0d9981c3bd66dc754f3d3cd</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>The remarks. The maximum length is 32 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The verification scenario ID. This ID is automatically generated after you create a verification scenario in the console. For information about how to create a verification scenario, see Add a verification scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000xxxx</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>The ServiceCode of the ID Verification cloud service. Set this parameter to <b>antcloudauth</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>antcloudauth</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The number of days the whitelist entry is valid. Valid values: 3, 7, and 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ValidDay")]
        [Validation(Required=false)]
        public int? ValidDay { get; set; }

    }

}
