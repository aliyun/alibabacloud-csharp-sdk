// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageListBySensitiveFileRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The image digest.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v005</para>
        /// </summary>
        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the specified container image.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/451339.html">ListRepository</a> operation to obtain the IDs of container images from the value of the <b>InstanceId</b> response parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-qewqrqcsadf****</para>
        /// </summary>
        [NameInMap("RepoInstanceId")]
        [Validation(Required=false)]
        public string RepoInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the image repository.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>harbor-image-v001</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The namespace to which the image repository belongs.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>libssh2</para>
        /// </summary>
        [NameInMap("RepoNamespace")]
        [Validation(Required=false)]
        public string RepoNamespace { get; set; }

        /// <summary>
        /// <para>The risk level of the file. Separate multiple levels with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>low</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>An array consisting of the types of the assets that you want to scan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image</b></description></item>
        /// <item><description><b>container</b></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// <para>The type of the alert for the sensitive file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>npm_token</b>: npm access token.</description></item>
        /// <item><description><b>ftp_cfg</b>: FTP configuration.</description></item>
        /// <item><description><b>google_oauth_key</b>: Google OAuth key.</description></item>
        /// <item><description><b>planetscale_passwd</b>: PlanetScale password.</description></item>
        /// <item><description><b>github_ssh_key</b>: Github SSH key.</description></item>
        /// <item><description><b>msbuild_publish_profile</b>: MSBuild publish profile.</description></item>
        /// <item><description><b>fastly_cdn_token</b>: Fastly CDN token.</description></item>
        /// <item><description><b>ssh_private_key</b>: SSH private key.</description></item>
        /// <item><description><b>aws_cli</b>: Amazon Web Services (AWS) CLI credential.</description></item>
        /// <item><description><b>cpanel_proftpd</b>: cPanel ProFTPD credential.</description></item>
        /// <item><description><b>postgresql_passwd</b>: PostgreSQL password file.</description></item>
        /// <item><description><b>discord_client_cred</b>: Discord client credential.</description></item>
        /// <item><description><b>rails_database</b>: Rails database configuration.</description></item>
        /// <item><description><b>aws_access_key</b>: AWS access key.</description></item>
        /// <item><description><b>esmtp_cfg</b>: configuration of mail server over Extended Simple Mail Transfer Protocol (ESMTP).</description></item>
        /// <item><description><b>docker_registry_cfg</b>: configuration of a Docker image repository.</description></item>
        /// <item><description><b>pem</b>: Privacy-Enhanced Mail (PEM).</description></item>
        /// <item><description><b>common_cred</b>: common credential.</description></item>
        /// <item><description><b>sftp_cfg</b>: configuration of connection over Secure File Transfer Protocol (SFTP).</description></item>
        /// <item><description><b>grafana_token</b>: Grafana token.</description></item>
        /// <item><description><b>slack_token</b>: Slack token.</description></item>
        /// <item><description><b>ec_private_key</b>: Elliptic Curve (EC) private key.</description></item>
        /// <item><description><b>pypi_token</b>: Python Package Index (PyPI) token.</description></item>
        /// <item><description><b>finicity_token</b>: Finicity token.</description></item>
        /// <item><description><b>k8s_client_key</b>: private key for the Kubernetes client.</description></item>
        /// <item><description><b>git_cfg</b>: Git configuration.</description></item>
        /// <item><description><b>django_key</b>: Django key.</description></item>
        /// <item><description><b>jenkins_ssh</b>: SSH configuration file for Jenkins.</description></item>
        /// <item><description><b>openssh_private_key</b>: OpenSSH private key.</description></item>
        /// <item><description><b>square_oauth</b>: Square OAuth credential.</description></item>
        /// <item><description><b>typeform_token</b>: Typeform token.</description></item>
        /// <item><description><b>common_database_cfg</b>: configuration of general database connection.</description></item>
        /// <item><description><b>wordpress_database_cfg</b>: WordPress database configuration.</description></item>
        /// <item><description><b>googlecloud_api_key</b>: API key for Google Cloud.</description></item>
        /// <item><description><b>vscode_sftp</b>: VSCode SFTP configuration.</description></item>
        /// <item><description><b>apache_htpasswd</b>: Apache htpasswd.</description></item>
        /// <item><description><b>planetscale_token</b>: PlanetScale token.</description></item>
        /// <item><description><b>contentful_preview_token</b>: preview token for Contentful.</description></item>
        /// <item><description><b>php_database_cfg</b>: database password for a PHP application.</description></item>
        /// <item><description><b>atom_remote_sync</b>: Atom remote synchronization configuration.</description></item>
        /// <item><description><b>aws_session_token</b>: AWS session token.</description></item>
        /// <item><description><b>atom_sftp_cfg</b>: Atom SFTP configuration.</description></item>
        /// <item><description><b>asana_client_private_key</b>: private key for the Asana client.</description></item>
        /// <item><description><b>tencentcloud_ak</b>: secret ID of a third-party cloud.</description></item>
        /// <item><description><b>rsa_private_key</b>: Rivest-Shamir-Adleman (RSA) private key.</description></item>
        /// <item><description><b>github_personal_token</b>: personal access token for GitHub.</description></item>
        /// <item><description><b>pgp</b>: Pretty Good Privacy (PGP) encrypted file.</description></item>
        /// <item><description><b>stripe_skpk</b>: Stripe secret key.</description></item>
        /// <item><description><b>square_token</b>: Square access token.</description></item>
        /// <item><description><b>rails_carrierwave</b>: Rails Carrierwave credential.</description></item>
        /// <item><description><b>dbeaver_database_cfg</b>: DBeaver database configuration.</description></item>
        /// <item><description><b>robomongo_cred</b>: RoboMongo credential.</description></item>
        /// <item><description><b>github_oauth_token</b>: OAuth access token for GitHub.</description></item>
        /// <item><description><b>pulumi_token</b>: Pulumi token.</description></item>
        /// <item><description><b>ventrilo_voip</b>: configuration of a Ventrilo VoIP server.</description></item>
        /// <item><description><b>macos_keychain</b>: macOS keychain.</description></item>
        /// <item><description><b>amazon_mws_token</b>: Amazon MWS token.</description></item>
        /// <item><description><b>dynatrace_token</b>: Dynatrace token.</description></item>
        /// <item><description><b>java_keystore</b>: Java KeyStore (JKS).</description></item>
        /// <item><description><b>microsoft_sdf</b>: Microsoft SQL Server Compact Edition (CE) database.</description></item>
        /// <item><description><b>kubernetes_dashboard_cred</b>: user credential for Kubernetes Dashboard.</description></item>
        /// <item><description><b>atlassian_token</b>: Atlassian token.</description></item>
        /// <item><description><b>rdp</b>: remote desktop protocol (RDP).</description></item>
        /// <item><description><b>mailgun_key</b>: Mailgun webhook signing key.</description></item>
        /// <item><description><b>mailchimp_api_key</b>: API key for Mailchimp.</description></item>
        /// <item><description><b>netrc_cfg</b>: .netrc configuration file.</description></item>
        /// <item><description><b>openvpn_cfg</b>: configuration of the OpenVPN client.</description></item>
        /// <item><description><b>github_refresh_token</b>: GitHub refresh token.</description></item>
        /// <item><description><b>salesforce</b>: Salesforce credential.</description></item>
        /// <item><description><b>salesforce</b>: Sendinblue token.</description></item>
        /// <item><description><b>pkcs_private_key</b>: PKCS#12 private key.</description></item>
        /// <item><description><b>rubyonrails_passwd</b>: Ruby on Rails password file.</description></item>
        /// <item><description><b>filezilla_ftp</b>: FileZilla FTP configuration.</description></item>
        /// <item><description><b>databricks_token</b>: Databricks token.</description></item>
        /// <item><description><b>gitLab_personal_toke</b>: personal access token for GitLab.</description></item>
        /// <item><description><b>rails_master_key</b>: Rails master key.</description></item>
        /// <item><description><b>sqlite</b>: SQLite3 or SQLite database.</description></item>
        /// <item><description><b>firefox_logins</b>: Firefox logon configuration.</description></item>
        /// <item><description><b>mailgun_private_token</b>: Mailgun private token.</description></item>
        /// <item><description><b>joomla_cfg</b>: Joomla configuration.</description></item>
        /// <item><description><b>hashicorp_terraform_token</b>: HashiCorp Terraform token.</description></item>
        /// <item><description><b>jetbrains_ides</b>: JetBrains IDEs configuration.</description></item>
        /// <item><description><b>heroku_api_key</b>: API key for Heroku.</description></item>
        /// <item><description><b>messagebird_token</b>: MessageBird token.</description></item>
        /// <item><description><b>github_app_token</b>: Github app token.</description></item>
        /// <item><description><b>hashicorp_vault_token</b>: HashiCorp Vault token.</description></item>
        /// <item><description><b>pgp_private_key</b>: PGP private key.</description></item>
        /// <item><description><b>sshpasswd</b>: SSH password.</description></item>
        /// <item><description><b>huaweicloud_ak</b>: secret access key of a third-party cloud.</description></item>
        /// <item><description><b>aws_s3cmd</b>: AWS S3cmd configuration.</description></item>
        /// <item><description><b>php_config</b>: PHP configuration.</description></item>
        /// <item><description><b>common_private_key</b>: common private key.</description></item>
        /// <item><description><b>microsoft_mdf</b>: Microsoft SQL Server database.</description></item>
        /// <item><description><b>mediawiki_cfg</b>: MediaWiki configuration.</description></item>
        /// <item><description><b>jenkins_cred</b>: Jenkins credential.</description></item>
        /// <item><description><b>rubygems_cred</b>: RubyGems credential.</description></item>
        /// <item><description><b>clojars_token</b>: Clojars token.</description></item>
        /// <item><description><b>phoenix_web_passwd</b>: Phoenix web credential.</description></item>
        /// <item><description><b>puttygen_private_key</b>: PuTTYgen private key.</description></item>
        /// <item><description><b>google_oauth_token</b>: Google OAuth access token.</description></item>
        /// <item><description><b>rubyonrails_cfg</b>: Ruby On Rails database configuration.</description></item>
        /// <item><description><b>lob_api_key</b>: Lob API key for Lob.</description></item>
        /// <item><description><b>pkcs_cred</b>: PKCS#12 certificate.</description></item>
        /// <item><description><b>otr_private_key</b>: Off-the-Record Messaging (OTR) private key.</description></item>
        /// <item><description><b>contentful_delivery_token</b>: Contentful delivery token.</description></item>
        /// <item><description><b>digital_ocean_tugboat</b>: DigitalOcean Tugboat configuration.</description></item>
        /// <item><description><b>dsa_private_key</b>: Digital Signature Algorithm (DSA) private key.</description></item>
        /// <item><description><b>rails_app_token</b>: app token for Rails.</description></item>
        /// <item><description><b>git_cred</b>: user credential for Git.</description></item>
        /// <item><description><b>newrelic_api_key</b>: User API key for New Relic.</description></item>
        /// <item><description><b>github_hub</b>: hub configuration for storing GitHub tokens.</description></item>
        /// <item><description><b>rubygem</b>: RubyGem token.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sshpasswd</para>
        /// </summary>
        [NameInMap("SensitiveFileKey")]
        [Validation(Required=false)]
        public string SensitiveFileKey { get; set; }

        /// <summary>
        /// <para>The sensitive file status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: unhandled</description></item>
        /// <item><description><b>1</b>: ignored</description></item>
        /// <item><description><b>2</b>: false positive</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
