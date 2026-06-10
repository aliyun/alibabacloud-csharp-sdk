// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class UploadAppSiteValidationFileRequest : TeaModel {
        /// <summary>
        /// <para>business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>domain name</para>
        /// 
        /// <b>Example:</b>
        /// <para>yjdw.bpu.edu.cn-waf</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>file name</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;URI\&quot;: \&quot;oss://imm-test-co-cn-chengdu/zqh/input/Image/indexImage/nn1.jpg\&quot;, \&quot;LatLong\&quot;:\&quot;+39.998800,+116.480900\&quot;}</para>
        /// </summary>
        [NameInMap("File")]
        [Validation(Required=false)]
        public string File { get; set; }

        /// <summary>
        /// <para>file content</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("FileContent")]
        [Validation(Required=false)]
        public string FileContent { get; set; }

        /// <summary>
        /// <para>file type</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP_MAPPING</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>site host</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("SiteHost")]
        [Validation(Required=false)]
        public string SiteHost { get; set; }

    }

}
