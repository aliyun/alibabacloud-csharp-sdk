// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmExtractTaskShrinkRequest : TeaModel {
        [NameInMap("CsvControl")]
        [Validation(Required=false)]
        public string CsvControlShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DocumentIsCapture")]
        [Validation(Required=false)]
        public bool? DocumentIsCapture { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/test-****.pdf">https://example.com/test-****.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-****.pdf</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VideoSpeed")]
        [Validation(Required=false)]
        public string VideoSpeed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PureDocument</para>
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

    }

}
