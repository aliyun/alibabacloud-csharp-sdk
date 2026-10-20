// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextCorrectRequest : Darabonba.Model {
        /// <summary>
        /// <para>The source language code. This parameter is required. You can set this parameter to auto for automatic language detection. 14 languages are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The text to correct. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Empfelung</para>
        /// </summary>
        [NameInMap("SourceText")]
        [Validation(Required=false)]
        public string SourceText { get; set; }

    }

}

