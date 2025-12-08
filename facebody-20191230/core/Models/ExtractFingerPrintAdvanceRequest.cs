// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ExtractFingerPrintAdvanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>iVBORw0KGgoAAAANSUhEUgAAASUAA****</para>
        /// </summary>
        [NameInMap("ImageData")]
        [Validation(Required=false)]
        public string ImageData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/xuhan/ExtractFingerPrint.png">https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/xuhan/ExtractFingerPrint.png</a></para>
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

    }

}
