// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10012150000</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// <para>The application name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DingTalk</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The application category ID. Exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The application category name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office Collaboration</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The application description. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The application group name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dingtalk</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The language of the returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese. This is the default value.</description></item>
        /// <item><description><b>en</b>: English.
        /// This parameter determines whether the application name, category name, technology type, vendor, and description are returned in Chinese or English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value must be greater than or equal to 1. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The risk level. Exact match is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Information</b>: Informational.</description></item>
        /// <item><description><b>Low</b>: Low.</description></item>
        /// <item><description><b>Medium</b>: Medium.</description></item>
        /// <item><description><b>High</b>: High.</description></item>
        /// <item><description><b>Critical</b>: Critical.
        /// If an invalid value is specified, this filter condition is ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Low</para>
        /// </summary>
        [NameInMap("Risk")]
        [Validation(Required=false)]
        public string Risk { get; set; }

        /// <summary>
        /// <para>The technology type name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Browser-based</para>
        /// </summary>
        [NameInMap("Technology")]
        [Validation(Required=false)]
        public string Technology { get; set; }

    }

}
