// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MedicalAnswerRaDoc : TeaModel {
        /// <summary>
        /// <para>The content summary of the reference source. Summaries can be returned for medical web pages and drug instructions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Stomach pain can be caused by various factors, including gastrointestinal spasms, inflammation, urinary tract stones, and menstrual pain. It can be relieved by applying a warm compress to the abdomen or treated by taking pain-relieving medication</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The URL of the reference source. This can be an empty string for sources such as papers, clinical guidelines, and books.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com/article/4CD364Mm8hh.html">https://www.example.com/article/4CD364Mm8hh.html</a></para>
        /// </summary>
        [NameInMap("rawUrl")]
        [Validation(Required=false)]
        public string RawUrl { get; set; }

        /// <summary>
        /// <para>The title of the reference source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>How to quickly and easily relieve stomach pain</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The type of the reference source, such as medical web pages, medical books, papers, or clinical guidelines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>med_web_source</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
