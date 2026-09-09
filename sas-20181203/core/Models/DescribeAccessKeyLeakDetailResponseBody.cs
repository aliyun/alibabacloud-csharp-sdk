// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAccessKeyLeakDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The leaked AccessKey ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAccessKeyID</para>
        /// </summary>
        [NameInMap("AccesskeyId")]
        [Validation(Required=false)]
        public string AccesskeyId { get; set; }

        /// <summary>
        /// <para>The platform where the asset resides. The value is fixed as <b>Cloud Platform</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud Platform</para>
        /// </summary>
        [NameInMap("Asset")]
        [Validation(Required=false)]
        public string Asset { get; set; }

        /// <summary>
        /// <para>The leaked code snippet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\n1231 \nak=yourAccessKeyID \n12311123 \nsk1999 \nsk1999sk1999 \nsk1999sk1999 \n\n\ntest001 ak hht \nak=yourAccessKeyID \nsk=yourAccessKeySecret</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time when the AccessKey pair leak event was handled. The value is in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-17 15:47:08</para>
        /// </summary>
        [NameInMap("DealTime")]
        [Validation(Required=false)]
        public string DealTime { get; set; }

        /// <summary>
        /// <para>The handling method of the AccessKey pair leak event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>manual</b>: Confirmed manual deletion.</description></item>
        /// <item><description><b>disable</b>: Manually disabled.</description></item>
        /// <item><description><b>add-whitelist</b>: Added to the whitelist.</description></item>
        /// <item><description><b>pending</b>: Not handled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>add-whitelist</para>
        /// </summary>
        [NameInMap("DealType")]
        [Validation(Required=false)]
        public string DealType { get; set; }

        /// <summary>
        /// <para>The GitHub file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testAkLeak</para>
        /// </summary>
        [NameInMap("GithubFileName")]
        [Validation(Required=false)]
        public string GithubFileName { get; set; }

        /// <summary>
        /// <para>The GitHub file type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Python</description></item>
        /// <item><description>XML</description></item>
        /// <item><description>GO</description></item>
        /// <item><description>Javascript</description></item>
        /// <item><description>INI</description></item>
        /// <item><description>JSON</description></item>
        /// <item><description>C++</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Python</para>
        /// </summary>
        [NameInMap("GithubFileType")]
        [Validation(Required=false)]
        public string GithubFileType { get; set; }

        /// <summary>
        /// <para>The time when the GitHub file was updated. The value is in the YYYY-MM-DDTHH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06T09:49:33</para>
        /// </summary>
        [NameInMap("GithubFileUpdateTime")]
        [Validation(Required=false)]
        public string GithubFileUpdateTime { get; set; }

        /// <summary>
        /// <para>The URL of the GitHub file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://github.com/Blue00Blue/ExamOnline/blob/6c932c10fc3f217783f3937e2b230f79656c18a7/testAk">https://github.com/Blue00Blue/ExamOnline/blob/6c932c10fc3f217783f3937e2b230f79656c18a7/testAk</a>****</para>
        /// </summary>
        [NameInMap("GithubFileUrl")]
        [Validation(Required=false)]
        public string GithubFileUrl { get; set; }

        /// <summary>
        /// <para>The GitHub repository name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExamOnline</para>
        /// </summary>
        [NameInMap("GithubRepoName")]
        [Validation(Required=false)]
        public string GithubRepoName { get; set; }

        /// <summary>
        /// <para>The GitHub repository URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://github.com/Blue00Blue/ExamOn">https://github.com/Blue00Blue/ExamOn</a>****</para>
        /// </summary>
        [NameInMap("GithubRepoUrl")]
        [Validation(Required=false)]
        public string GithubRepoUrl { get; set; }

        /// <summary>
        /// <para>The GitHub username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Blue00Blue</para>
        /// </summary>
        [NameInMap("GithubUser")]
        [Validation(Required=false)]
        public string GithubUser { get; set; }

        /// <summary>
        /// <para>The profile picture URL of the GitHub user.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://avatars.githubusercontent.com/u/26296896?s=48&v=">https://avatars.githubusercontent.com/u/26296896?s=48&amp;v=</a>****</para>
        /// </summary>
        [NameInMap("GithubUserPicUrl")]
        [Validation(Required=false)]
        public string GithubUserPicUrl { get; set; }

        /// <summary>
        /// <para>The time when the AccessKey pair leak event was first discovered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06 17:49:41</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The most recent discovery time of the leak event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-06 17:49:39</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The remarks of the AccessKey pair leak event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79CFF74D-E967-5407-8A78-EE03B925FDAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The intelligence source of the AccessKey pair leak event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GitHub</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The validity of the key associated with the AccessKey pair. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: To be confirmed.</description></item>
        /// <item><description><b>1</b>: Valid.</description></item>
        /// <item><description><b>2</b>: Invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TokenValid")]
        [Validation(Required=false)]
        public int? TokenValid { get; set; }

        /// <summary>
        /// <para>The type of the leaked information. The value is fixed as <b>AccessKey</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AccessKey</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Indicates whether the AccessKey pair leak event is added to the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>no</b>: Not added to the whitelist.</description></item>
        /// <item><description><b>yes</b>: Added to the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("WhitelistStatus")]
        [Validation(Required=false)]
        public string WhitelistStatus { get; set; }

        /// <summary>
        /// <para>The time when the AccessKey pair was added to the whitelist. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1689172004478</para>
        /// </summary>
        [NameInMap("WhitelistTime")]
        [Validation(Required=false)]
        public long? WhitelistTime { get; set; }

    }

}
