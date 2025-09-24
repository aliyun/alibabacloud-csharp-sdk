// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class ModifyFaceRecordRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87</para>
        /// </summary>
        [NameInMap("FaceGroupCode")]
        [Validation(Required=false)]
        public string FaceGroupCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("ImgOssInfos")]
        [Validation(Required=false)]
        public string ImgOssInfos { get; set; }

    }

}
