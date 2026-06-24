// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDictInformationRequest : TeaModel {
        /// <summary>
        /// <para>The type of the OSS dictionary to be added. Valid values: IK_HOT, IK, SYNONYMS, and ALIWS. Default value: IK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIWS</para>
        /// </summary>
        [NameInMap("analyzerType")]
        [Validation(Required=false)]
        public string AnalyzerType { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket where the dictionary file is stored.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>search-cloud-test-cn-****</para>
        /// </summary>
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The storage path of the dictionary file in the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss/dic_0.dic</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

    }

}
