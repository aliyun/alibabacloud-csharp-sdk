// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAppRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testApp.apk</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://test.png">https://test.png</a></para>
        /// </summary>
        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-d</para>
        /// </summary>
        [NameInMap("InstallParam")]
        [Validation(Required=false)]
        public string InstallParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://testApp.apk">http://testApp.apk</a></para>
        /// </summary>
        [NameInMap("OssAppUrl")]
        [Validation(Required=false)]
        public string OssAppUrl { get; set; }

    }

}
